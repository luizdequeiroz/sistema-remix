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

function submitMenu(id) {
    resetMenu();

    $('#' + id).css('border', '3px solid darkred');
    $('#pagina').val(id);
    $('#menu-form').submit();
}

function submitFichas(id) {

    $('#pagFichas').val(id);
    $('#novaFicha-form').submit();
}

var menuActived = true;

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

    $('#active-menu').dblclick(function () {

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