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

    function resetMenu() {
        $('#fichas').css('border', 'none');
        $('#jogadores').css('border', 'none');
        $('#textos').css('border', 'none');
        $('#mapas').css('border', 'none');
    }

    $('#fichas').click(function () {
        resetMenu();
        $('#fichas').css('border', '3px solid darkred');
        $('#frame').attr('src', '/Desktop/Fichas');
    });

    $('#jogadores').click(function () {
        resetMenu();
        $('#jogadores').css('border', '3px solid darkred');
        $('#frame').attr('src', '/Desktop/Jogadores');
    });

    $('#textos').click(function () {
        resetMenu();
        $('#textos').css('border', '3px solid darkred');
        $('#frame').attr('src', '/Desktop/Textos');
    });

    $('#mapas').click(function () {
        resetMenu();
        $('#mapas').css('border', '3px solid darkred');
        $('#frame').attr('src', '../Content/zoldamaps/Default.html');
    });

    $('#novaficha').click(function () {
        $('#frame').attr('src', '/Desktop/NovaFicha');
    });
});