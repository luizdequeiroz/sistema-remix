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
    $('#Fichas').css('border', '1px solid transparent');
    $('#Jogadores').css('border', '1px solid transparent');
    $('#Textos').css('border', '1px solid transparent');
    $('#Mapas').css('border', '1px solid transparent');

    $('#Fichas').css('border-color', '#cccccc');
    $('#Jogadores').css('border-color', '#cccccc');
    $('#Textos').css('border-color', '#cccccc');
    $('#Mapas').css('border-color', '#cccccc');
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

function submit(method, controller, action) {
    var dados = $('form').serialize();

    $.ajax({
        type: method,
        url: '/' + controller + '/' + action,
        data: dados,
        success: function (view) {
            $('#frame').html(view);
        }
    });
}

function sumAllTests() {
    return parseInt($('#Adre').val())
         + parseInt($('#Ataq').val())
         + parseInt($('#Defe').val())
         + parseInt($('#Dest').val())
         + parseInt($('#Forc').val())
         + parseInt($('#Inte').val())
         + parseInt($('#Resi').val())
         + parseInt($('#Sabe').val())
         + parseInt($('#Velo').val());
}

function appendAllTests(val) {
    $('#Adre').val(val);
    $('#Ataq').val(val);
    $('#Defe').val(val);
    $('#Dest').val(val);
    $('#Forc').val(val);
    $('#Inte').val(val);
    $('#Resi').val(val);
    $('#Sabe').val(val);
    $('#Velo').val(val);
}

var ptsTest;
var ptsPecs;

function calcPts(val) {
    var test = parseInt(val) - 2.5;
    ptsTest = parseInt(test * 9);
    ptsPecs = parseInt(test * 10);

    appendAllTests(0);

    $('#ptsTest').val(sumAllTests() + '/' + ptsTest);
    $('#ptsPecs').val(ptsPecs);

    $('#Nivel').val(parseInt(test));

    $('#submiter').attr('disabled', false);
}

function defineMaxAllTests(max) {
    if (max == 0) {
        $('#Adre').attr('max', $('#Adre').val());
        $('#Ataq').attr('max', $('#Ataq').val());
        $('#Defe').attr('max', $('#Defe').val());
        $('#Dest').attr('max', $('#Dest').val());
        $('#Forc').attr('max', $('#Forc').val());
        $('#Inte').attr('max', $('#Inte').val());
        $('#Resi').attr('max', $('#Resi').val());
        $('#Sabe').attr('max', $('#Sabe').val());
        $('#Velo').attr('max', $('#Velo').val());
    } else {
        $('#Adre').attr('max', max);
        $('#Ataq').attr('max', max);
        $('#Defe').attr('max', max);
        $('#Dest').attr('max', max);
        $('#Forc').attr('max', max);
        $('#Inte').attr('max', max);
        $('#Resi').attr('max', max);
        $('#Sabe').attr('max', max);
        $('#Velo').attr('max', max);
    }
}

function calcPtsTest(id) {
    var pts = $('#' + id).val();

    if (sumAllTests() == ptsTest) defineMaxAllTests(0);
    else defineMaxAllTests(18);

    $('#ptsTest').val(sumAllTests() + '/' + ptsTest);
}

function sort(id) {
    var x = Math.floor((Math.random() * 20) + 1);
    var y = 0;
    if (x <= 4) y = Math.floor((Math.random() * 8) + 1);
    else if (x <= 8) y = Math.floor((Math.random() * 6) + 1);
    else if (x <= 12) y = Math.floor((Math.random() * 4) + 1);
    else if (x <= 16) y = Math.floor((Math.random() * 6) + 1);
    else if (x <= 20) y = Math.floor((Math.random() * 8) + 1);

    if (x > 10) x = x - y;
    else x = x + y;

    $('#' + id).val(x);
    $('#' + id).attr('disabled', true);
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
});

/*
<div class="form-group-sm form-inline group-test">
    <input type="text" name="capacidades[0].Nome" id="capacidades[0].Nome" class="form-control pecu-name" placeholder="nome da capacidade" />
    <input type="number" name="capacidades[0].Teste" id="capacidades[0].Teste" min="0" class="form-control pecu-test" placeholder="teste" />
</div>
*/

var numCaps = 0;
var numPers = 0;
var numDesv = 0;

function maisCap() {
    var div = document.createElement('div');
    div.className = 'form-group-sm form-inline group-test';

    var inputText = document.createElement('input');
    inputText.type = 'text';
    inputText.name = 'capacidades[' + numCaps + '].Nome';
    inputText.id = 'capacidades[' + numCaps + '].Nome';
    inputText.className = 'form-control pecu-name';
    inputText.placeholder = 'nome da capacidade';

    var inputNumber = document.createElement('input');
    inputNumber.type = 'number';
    inputNumber.name = 'capacidades[' + numCaps + '].Teste';
    inputNumber.id = 'capacidades[' + numCaps + '].Teste';
    inputNumber.min = '0';
    inputNumber.className = 'form-control pecu-test';
    inputNumber.placeholder = 'teste';

    div.appendChild(inputText);
    div.appendChild(inputNumber);

    document.getElementById('caps').appendChild(div);

    numCaps++;
}

function maisPer() {
    var div = document.createElement('div');
    div.className = 'form-group-sm form-inline group-test';

    var inputText = document.createElement('input');
    inputText.type = 'text';
    inputText.name = 'pericias[' + numPers + '].Nome';
    inputText.id = 'pericias[' + numPers + '].Nome';
    inputText.className = 'form-control pecu-name';
    inputText.placeholder = 'nome da perícia';

    var inputNumber = document.createElement('input');
    inputNumber.type = 'number';
    inputNumber.name = 'pericias[' + numPers + '].Teste';
    inputNumber.id = 'pericias[' + numPers + '].Teste';
    inputNumber.min = '0';
    inputNumber.className = 'form-control pecu-test';
    inputNumber.placeholder = 'teste';

    div.appendChild(inputText);
    div.appendChild(inputNumber);

    document.getElementById('pers').appendChild(div);

    numPers++;
}

function maisDes() {
    var div = document.createElement('div');
    div.className = 'form-group-sm form-inline group-test';

    var inputText = document.createElement('input');
    inputText.type = 'text';
    inputText.name = 'desvantagens[' + numDesv + '].Nome';
    inputText.id = 'desvantagens[' + numDesv + '].Nome';
    inputText.className = 'form-control pecu-name';
    inputText.placeholder = 'nome da desvantagem';

    var inputNumber = document.createElement('input');
    inputNumber.type = 'number';
    inputNumber.name = 'desvantagens[' + numDesv + '].Teste';
    inputNumber.id = 'desvantagens[' + numDesv + '].Teste';
    inputNumber.min = '0';
    inputNumber.className = 'form-control pecu-test';
    inputNumber.placeholder = 'teste';

    div.appendChild(inputText);
    div.appendChild(inputNumber);

    document.getElementById('desv').appendChild(div);

    numDesv++;
}