var addUserBtn = document.getElementById('addUser'),
    editUserBtn = document.getElementById('editUser'),
    showUsersBtn = document.getElementById('showUsers'),
    delUserBtn = document.getElementById('delUser'),
    getUserbyIdBtn = document.getElementById('getUserById'),
    addAwardBtn = document.getElementById('addAward'),
    editAwardBtn = document.getElementById('editAward'),
    delAwardBtn = document.getElementById('delAward'),
    showAwardsBtn = document.getElementById('showAwards'),
    getAwardByIdBtn = document.getElementById('getAwardById'),
    addAwardToUserBtn = document.getElementById('addAwardToUser');


function redirect(url) {
    location = url;
}

showUsersBtn.onclick = function () {
    redirect('/pages/GetAllUsers.cshtml');
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUser.cshtml');
}

delUserBtn.onclick = function () {
    redirect('/pages/DeleteUser.cshtml');
}

getUserbyIdBtn.onclick = function () {
    redirect('/pages/GetUserById.cshtml');
}

addAwardBtn.onclick = function () {
    redirect('/pages/AddAward.cshtml');
}

delAwardBtn.onclick = function () {
    redirect('/pages/DeleteAward.cshtml');
}

showAwardsBtn.onclick = function () {
    redirect('/pages/GetAllAwards.cshtml');
}

getAwardByIdBtn.onclick = function () {
    redirect('/pages/GetAwardById.cshtml');
}

addAwardToUserBtn.onclick = function () {
    redirect('/pages/AddAwardToUser.cshtml');
}

editUserBtn.onclick = function () {
    redirect('/pages/EditUser.cshtml');
}

editAwardBtn.onclick = function () {
    redirect('/pages/EditAward.cshtml');
}

