import APISettings from './APISettings';
var ChatEndpoints = [
    {
        Name: ChatEndpointType.GetDialogs,
        EndPoint: BuildPathEndpoint("chat","getDialogs"),
        Method: "GET",
        Request: { UserId: 0 },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.GetMessages,
        EndPoint: BuildPathEndpoint("chat","getMessages"),
        Method: "GET",
        Request: { IdDialog: 0, DateFrom: Date.now(), CountMessage: 100  },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.CreateDialog,
        EndPoint: BuildPathEndpoint("chat","createDialog"),
        Method: "POST",
        Request: { UsersId : [0]  },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.DeleteDialog,
        EndPoint: BuildPathEndpoint("chat","deleteDialog"),
        Method: "DELETE",
        Request: { DialogId : 0  },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.CreateMessage,
        EndPoint: BuildPathEndpoint("chat","createMessage"),
        Method: "POST",
        Request: { UserId : 0, DialogId: 0, Message: "", Files:[] },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.UpdateMessage,
        EndPoint: BuildPathEndpoint("chat","updateMessage"),
        Method: "PUT",
        Request: { MessagId: 0, Text: "" },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.DeleteMessage,
        EndPoint: BuildPathEndpoint("chat","deleteMessage"),
        Method: "DELETE",
        Request: { MessageId: 0 },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.ReactionMessage,
        EndPoint: BuildPathEndpoint("chat","reactionMessage"),
        Method: "POST",
        Request: { IdMessage: 0, IdUser: 0, EmojiType: 0 },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: ChatEndpointType.DownloadFile,
        EndPoint: BuildPathEndpoint("chat","downloadFile"),
        Method: "GET",
        Request: { IdFile: 0 },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
];

function BuildPathEndpoint(category, path)
{
    return APISettings.Host+":"+APISettings.Port+APISettings.BasePoint+category+"/"+path;
}

var ChatEndpointType = {
    GetDialogs: 0,
    GetMessages: 1,
    CreateDialog: 2,
    DeleteDialog: 3,
    CreateMessage: 4,
    UpdateMessage: 5,
    DeleteMessage: 6,
    ReactionMessage: 7,
    DownloadFile: 8,
};
module.exports = {ChatEndpoints, ChatEndpointType};
