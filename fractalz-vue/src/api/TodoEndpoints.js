import APISettings from './APISettings';
var TodoEndpoints = [
    {
        Name: TodoEndpointType.GetList,
        EndPoint: BuildPathEndpoint("todoList","getList"),
        Method: "GET",
        Request: { UserId: 0, DateFrom: null },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: TodoEndpointType.CreateTask,
        EndPoint: BuildPathEndpoint("todoList","createTask"),
        Method: "POST",
        Request: { TodoListId: 0, Header: "", About: "", TimeStart: Date.now(), DurationInMinute: 0, DateCreate: Date.now() },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: TodoEndpointType.UpdateStatusTask,
        EndPoint: BuildPathEndpoint("todoList","updateStatusTask"),
        Method: "PUT",
        Request: { IdTask: 0, Completed: false },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: TodoEndpointType.DeleteTask,
        EndPoint: BuildPathEndpoint("todoList","deleteTask"),
        Method: "DELETE",
        Request: { IdTask: 0 },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
];

function BuildPathEndpoint(category, path)
{
    return APISettings.Host+":"+APISettings.Port+APISettings.BasePoint+category+"/"+path;
}

var TodoEndpointType = {
    GetList: 0,
    CreateTask: 1,
    UpdateStatusTask: 2,
    DeleteTask: 3,
};
module.exports = {TodoEndpoints, TodoEndpointType};
