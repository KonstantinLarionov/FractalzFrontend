import APISettings from './APISettings';

var UserEndpoints = [
    {
        Name: UserEndpointType.Reg,
        EndPoint: BuildPathEndpoint("user","registration"),
        Method: "POST",
        Request: { Login: "", Email: "", Password: "" },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: UserEndpointType.Login,
        EndPoint: BuildPathEndpoint("user","login"),
        Method: "GET",
        Request: { Login: "", Password: "" },
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
    {
        Name: UserEndpointType.UpdateProfile,
        EndPoint: BuildPathEndpoint("user","updateProfile"),
        Method: "GET",
        Request: { UserId: 0, Login: "", Name: "", Surname: "", Patro: "", Number: 0, Email: "", Logo: null},
        Headers : { 'Content-Type': 'application/json;charset=utf-8' }
    },
];

function BuildPathEndpoint(category, path)
{
    return APISettings.Host+":"+APISettings.Port+APISettings.BasePoint+category+"/"+path;
}

var UserEndpointType = {
    Reg: 0,
    Login: 1,
    UpdateProfile: 2,
};
module.exports = {UserEndpoints, UserEndpointType};
