var sbmtBtn = document.getElementById('Sbmt'),
    realSbmtBtn = document.getElementById('realSbmt');
realSbmtBtn.hidden = 1;

function redirect(url) {
    location = url;
}

sbmtBtn.onclick = function () {
    res = confirm("Do you really want to delete this award? This action will remove the award from all users! Press submit again to do it.");
    if (res)
        realSbmtBtn.click();
    else
        redirect('/pages/DeleteAward.cshtml');

    sbmtBtn.hidden = 1;
    realSbmtBtn.hidden = 0;
}