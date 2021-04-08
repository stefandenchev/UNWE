﻿var OpenWeatherAppKey = "2c24436d9d9a44bc6d9eae99d7835bb9"; //5bb30b963a0d79993b96acd6ce552b0c

function getWeatherWithCityName() {

    var cityName = $('#city-name-input').val();

    var queryString = 'http://api.openweathermap.org/data/2.5/weather?q='
        + cityName + '&appid=' + OpenWeatherAppKey + '&units=metric';

    $.getJSON(queryString, function (results) {
        showWeatherData(results);

    }).fail(function (jqXHR) {
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. " + jqXHR.statusText);
    });
    return false;
}

function showWeatherData(results) {

    $('#app-title').text("Android платформа");

    if (results.weather.length) {
        $('#error-msg').hide();
        $('#weather-data').show();

        $('#title').text(results.name);
        $('#temperature').text(results.main.temp);
        $('#wind').text(results.wind.speed);
        $('#humidity').text(results.main.humidity);
        $('#visibility').text(results.weather[0].main);

        var sunriseDate = new Date(results.sys.sunrise * 1000);
        $('#sunrise').text(sunriseDate.toLocaleTimeString());

        var sunsetDate = new Date(results.sys.sunset * 1000);
        $('#sunset').text(sunsetDate.toLocaleTimeString());

    } else {
        $('#weather-data').hide();
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. ");
    }
    $('#get-weather-btn').prop('disabled', false);
}

function getWeatherWithGeoLocation() {
    //Метод getCurrentPosition вика Cordova Geolocation API
    navigator.geolocation.getCurrentPosition(onGetLocationSuccess, onGetLocationError,
        { enableHighAccuracy: true });
    $('#error-msg').show();
    $('#error-msg').text('Determining your current location ...');
    $('#get-weather-btn').prop('disabled', true);
}
function onGetLocationSuccess(position) {
    //Изтегляне на информация за локацията на устройството от обекта position
    $('#get-weather-btn').prop('disabled', true);

    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;

    var queryString = 'http://api.openweathermap.org/data/2.5/weather?lat='
        + latitude + '&lon=' + longitude
        + '&appid=' + OpenWeatherAppKey + '&units=metric';
    $.getJSON(queryString, function (results) {
        showWeatherData(results);
    }).fail(function (jqXHR) {
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. " + jqXHR.statusText);
    });
    return false;
}

function onGetLocationError(error) {
    $('#error-msg').text('Error getting location');
    $('#get-weather-btn').prop('disabled', false);
}