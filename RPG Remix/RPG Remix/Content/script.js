/* Funções para carregamento com o GIF */
function loaderOn() {
    setTimeout(function () {
        $('.loading').css('display', 'normal');
    }, 5000);
}
function loaderOff() {
    $('.loading').css('display', 'none');
}

function resetMenu() {
    $('#Fichas').css('border', 'none');
    $('#Jogadores').css('border', 'none');
    $('#Textos').css('border', 'none');
    $('#Mapas').css('border', 'none');
}

function loadPage(controller, action) {

    $.ajax({
        type: 'GET',
        url: '/' + controller + '/' + action,
        success: function (view) {
            $('#frame').html(view);
        }
    });
}

function clickMenu(controller, action) {
    resetMenu();

    $('#' + action).css('border', '3px solid darkred');
    loadPage(controller, action);
}

var menuActived = true;

function submitFicha() {
    $('#novaFicha-form').submit();
}

$(document).ready(function () {

    $('#active-menu').click(function () {

        if (menuActived) {
            $('.desktop-menu').animate({ left: '-150px' }, 500);
            $('.desktop-content').animate({ left: '0' }, 500);
            menuActived = false;
        } else {
            $('.desktop-menu').animate({ left: '0' }, 500);
            $('.desktop-content').animate({ left: '150px' }, 500);
            menuActived = true;
        }
    });
});