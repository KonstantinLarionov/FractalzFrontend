using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.Responses.Todo;
using Fractalz.Application.Domains.Responses.User;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Models;
using FractalzFrontend.Models.TodoPart;
using FractalzFrontend.ViewModels.LoginPart;
using FractalzFrontend.ViewModels.TodoPart;

using Newtonsoft.Json;

using Ninject;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Views.TodoPart.Modals
{
    /// <summary>
    /// Логика взаимодействия для CreateTask.xaml
    /// </summary>
    public partial class CreateTask : Window
    {
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        private readonly TodoVM todoVM;
        private readonly TodoModel Model;

        public CreateTask(TodoModel model, TodoVM todoVM)
        {
            InitializeComponent();

            _rest = NinjectCollection
            .Integration
            .Services
                .Get<IRestClient>();

            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();

            Model = model;
            this.todoVM = todoVM;
            this.DateCreate.Text = DateTime.Now.ToString("d");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Header.Text))
            {
                MessageBox.Show("Для создания задачи нужно заполнить хотя бы заголовок");
                return;
            }
            var time = TimeCreate.SelectedTime;
            if (time is null)
                time = DateTime.Now;
            var date = DateTime.Parse(DateCreate.Text)
                                        .AddHours(time.Value.Hour)
                                        .AddMinutes(time.Value.Minute);
            var req = new
            {
                TodoListId = _cacheController.GetCache<User>("User_Info").TodoList.Id,
                Header = Header.Text,
                About = StringFromRichTextBox(About),
                DateCreate = date.ToString("s"),
            };

            var response = _rest
            .Send<CreateTaskResponse>(req,
                "/todoList/createTask",
                Method.POST,
                out var error);

            if (response.Success)
            {
                Model.AddNewTask(new ViewModels.TodoPart.TaskVM
                {
                    Visibility = Visibility.Visible,
                    IsDone = false,
                    Header = req.Header,
                    Description = req.About,
                    Datetime = date,
                    Id = response.IdTask.ToString(),
                    todoVM = this.todoVM,
                });
                this.Close();
            }
            else
                MessageBox.Show(error?.Message);
        }

        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                rtb.Document.ContentStart,
                rtb.Document.ContentEnd
            );
            return textRange.Text;
        }
    }
}
