/* Funções para carregamento com o GIF */
function loaderOn() {
    setTimeout(function () {
        $('.loading').css('display', 'normal');
    }, 5000);
}
function loaderOff() {
    $('.loading').css('display', 'none');
}

/* Função para o Click no Menu */
var id_old;
function menuClick(id_clicked) {

    $('#' + id_old).css('border', '');
    $('#' + id_clicked).css('border', 'solid 3px darkred');

    id_old = id_clicked;

    $('#pagina').val(id_clicked);
    $('#menu-form').submit();
}