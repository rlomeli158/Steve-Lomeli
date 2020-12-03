/*! jQuery Validation Plugin - v1.19.1 - 6/15/2019
 * https://jqueryvalidation.org/
 * Copyright (c) 2019 Jörn Zaefferer; Licensed MIT */
!function(a){"function"==typeof define&&define.amd?define(["jquery","../jquery.validate.min"],a):"object"==typeof module&&module.exports?module.exports=a(require("jquery")):a(jQuery)}(function(a){return a.extend(a.validator.messages,{required:"Acest câmp este obligatoriu.",remote:"Te rugăm să completezi acest câmp.",email:"Te rugăm să introduci o adresă de email validă",url:"Te rugăm sa introduci o adresă URL validă.",date:"Te rugăm să introduci o dată corectă.",dateISO:"Te rugăm să introduci o dată (ISO) corectă.",number:"Te rugăm să introduci un număr întreg valid.",digits:"Te rugăm să introduci doar cifre.",creditcard:"Te rugăm să introduci un numar de carte de credit valid.",equalTo:"Te rugăm să reintroduci valoarea.",extension:"Te rugăm să introduci o valoare cu o extensie validă.",maxlength:a.validator.format("Te rugăm să nu introduci mai mult de {0} caractere."),minlength:a.validator.format("Te rugăm să introduci cel puțin {0} caractere."),rangelength:a.validator.format("Te rugăm să introduci o valoare între {0} și {1} caractere."),range:a.validator.format("Te rugăm să introduci o valoare între {0} și {1}."),max:a.validator.format("Te rugăm să introduci o valoare egal sau mai mică decât {0}."),min:a.validator.format("Te rugăm să introduci o valoare egal sau mai mare decât {0}.")}),a});