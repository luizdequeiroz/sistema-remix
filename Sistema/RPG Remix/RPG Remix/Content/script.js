function loaderOn() {
    $('.loading').css('display', 'normal');
}
function loaderOff() {
    $('.loading').css('display', 'none');
}

var id_old;

function menuClick(id_clicked) {

    $('#' + id_old).css('border', '');
    $('#' + id_clicked).css('border', 'solid 3px darkred');

    id_old = id_clicked;

    $('#pagina').val(id_clicked);
    $('#menu-form').submit();
}