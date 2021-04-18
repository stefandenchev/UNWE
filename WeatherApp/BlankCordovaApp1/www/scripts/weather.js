const OpenWeatherAppKey = "2c24436d9d9a44bc6d9eae99d7835bb9";

function getWeatherWithCityName() {
    var cityName = $('#city-name-input').val();
    var queryString = 'http://api.openweathermap.org/data/2.5/forecast?q=' + cityName + '&appid=' + OpenWeatherAppKey + '&units=metric';
    $.getJSON(queryString, function (results) {
        showWeatherData(results);
    }).fail(function (jqXHR) {
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. " + jqXHR.statusText);
    });
    return false;

}

function appendWeatherDataToList(temp, windSpeed, humidity, dateTime, visibility, icon) {
    let tempDiv = `<div><span id="summary"><span id="temperature">${temp}</span> C <img src="" /></span></div>`;
    let windDiv = `<div>Вятър: <span id="wind">${windSpeed}</span> възела</div>`;
    let dateTimeDiv = `<div>Дата и час: ${dateTime}</div>`;
    let humidityDiv = `<div>Влажност: <span id="humidity">${humidity}</span> %</div>`;
    let visibilityDiv = `<div>Видимост: <span id="visibility">${visibility}</span></div>`;

    let iconUrl = "http://openweathermap.org/img/w/" + icon + ".png";
    let iconDiv = `<div><img src='${iconUrl}'></img></div>`;

    let parentContainer = `<li class="weather-card">${tempDiv}${iconDiv}${windDiv}${humidityDiv}${dateTimeDiv}${visibilityDiv}</li>`;

    $("#weather-data").append(parentContainer);
}

function showWeatherData(results) {
    if (results.list.length) {

        $('#error-msg').hide();
        $('#title').text(results.city.name);
        $('#weather-data').show();

        results.list.forEach(result => appendWeatherDataToList(result.main.temp, result.wind.speed, result.main.humidity, result.dt_txt,
            result.visibility, result.weather[0].icon));

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