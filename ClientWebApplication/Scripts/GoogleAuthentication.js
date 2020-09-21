/// <reference path="jquery-3.4.1.min.js" />

function GetAccessToken() {
    console.log('Test!');
    console.log(location);
    console.log(localStorage.getItem('accessToken'));
    console.log(localStorage.getItem('userName'));
    if (location.hash) {
        console.log(location.hash.split('access_token='));
        if (location.hash.split('access_token=')) {
            console.log(accessToken);
            var accessToken = location.hash.split('access_token')[1].split('&')[0];
            
            if (accessToken) {
                console.log(location.hash.split('isUserRegistered invoked'));
                isUserRegistered(accessToken);
            }
        }
    }
    alert('GetAccessToken(END)');
}

function isUserRegistered(accessToken) {
    alert('isUserRegistered()');
    $.ajax({
        url: 'https://localhost:44306/api/Account/UserInfo',
        method: 'GET',
        headers: {
            'contentType': 'application/JSON',
            'authorization': 'Bearer ' + accessToken 
        },
        success: function (response) {
            if (response.hasRegistered) {
                localStorage.setItem('accessToken', accessToken);
                localStorage.setItem('userName', response.email);
                window.location.href = 'https://localhost:44352/WebService/WebApiEmployee/Login'
            } else {
                signupExternalUser(accessToken);
            }
        }
    });
}

function signupExternalUser(accessToken) {
    alert('signupExternalUser()');
    $.ajax({
        url: 'https://localhost:44306/api/Account/RegisterExternal',
        method: 'POST',
        headers: {
            'contentType': 'application/JSON',
            'authorization': 'Bearer ' + accessToken
        },
        success: function () {
            window.location.href = 'https://localhost:44306/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=https%3A%2F%2Flocalhost%3A44306%2F&state=VDR8_J8Waenc81WXn2loQ6Kl9Oa1O-K12wyWGl1Md8w1';
        }
    });
}