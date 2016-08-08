/* Funções para carregamento com o GIF */
function loaderOn() {
    setTimeout(function () {
        $('.loading').css('display', 'normal');
    }, 5000);
}
function loaderOff() {
    $('.loading').css('display', 'none');
}

var menuActived = true;

$(document).ready(function () {

    $('#active-menu').click(function () {

        if (menuActived) {
            $('.desktop-menu').css('display', 'none');
            $('.desktop-content').css('left', '0');
            menuActived = false;
        } else {
            $('.desktop-menu').css('display', 'block');
            $('.desktop-content').css('left', '150px');
            menuActived = true;
        }

    });
});