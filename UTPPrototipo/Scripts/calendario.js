﻿
jQuery(function ($) {
    $.datepicker.regional['es'] = {
        closeText: 'Cerrar',
        prevText: 'Sig>',
    currentText: 'Hoy',
    monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio','Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
    monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun','Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
    dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
    dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié;', 'Juv', 'Vie', 'Sáb'],
    dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
    weekHeader: 'Sm',
    dateFormat: 'dd/mm/yy',

    firstDay: 1,
    isRTL: false,
    showMonthAfterYear: false,
    yearSuffix: ''


};
$.datepicker.setDefaults($.datepicker.regional['es']);
});

//function checkSupportForInputTypeDate() {
//    jQuery.validator.methods.date = function (value, element) {
//    debugger;
//        var isChrome = /Chrome/.test(navigator.userAgent) && /Google Inc/.test(navigator.vendor);
//        var isSafari = /Safari/.test(navigator.userAgent) && /Apple Computer/.test(navigator.vendor);
//        if (isSafari || isChrome) {
//            var d = new Date();
//            return this.optional(element) || !/Invalid|NaN/.test(new Date(d.toLocaleDateString(value)));
//        } else {
//            return this.optional(element) || !/Invalid|NaN/.test(new Date(value));
//        }
//    };
//}

//Se agrega un validador para las fechas en Peru.
$.validator.addMethod(
           "date",
           function (value, element) {
               var bits = value.match(/([0-9]+)/gi), str;
               if (!bits)
                   return this.optional(element) || false;
               str = bits[1] + '/' + bits[0] + '/' + bits[2];
               return this.optional(element) || !/Invalid|NaN/.test(new Date(str));
           },
           ""
       );