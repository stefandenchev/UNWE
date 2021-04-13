var OpenWeatherAppKey = "2c24436d9d9a44bc6d9eae99d7835bb9"; //5bb30b963a0d79993b96acd6ce552b0c

function getWeatherWithCityName() {
    var cityName = $('#city-name-input').val();
    var queryString = 'http://api.openweathermap.org/data/2.5/weather?q=' + cityName + '&appid=' + OpenWeatherAppKey + '&units=metric';
    $.getJSON(queryString, function (results) {
        showWeatherData(results);
    }).fail(function (jqXHR) {
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. " + jqXHR.statusText);
    });
    return false;
}

function showWeatherData(results) {
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

    var queryString = 'http://api.openweathermap.org/data/2.5/weather?lat=' + latitude + '&lon=' + longitude
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




function get5DayWeatherWithCityName() {
    var cityName = $('#city-name-input').val();
    var queryString = 'http://api.openweathermap.org/data/2.5/forecast?q=' + cityName + '&appid=' + OpenWeatherAppKey + '&units=metric';
    $.getJSON(queryString, function (results) {
        show5DayWeatherData(results);
    }).fail(function (jqXHR) {
        $('#error-msg').show();
        $('#error-msg').text("Error retrieving data. " + jqXHR.statusText);
    });
    return false;
}

function getHour(result, id) {
    let listItem = document.createElement("li");
    listItem.classList.add("city");
    let a = getWeatherData(result, id);
    li.innerHTML = a;
    documentList.appendChild(li);
}

function show5DayWeatherData(results) {
    if (results[0].weather.length) {
        $('#error-msg').hide();
        $('#weather-data').show();
        results.map((result, id) =>
        {
            getHour(result, id);
        });
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


fetch(url)
    .then(response => response.json())
    .then(forecast => {

        // For each day, we'll loop through and add it to the DOM:
        forecast.list.forEach(day => {

            // Create a new element to hold each day's data in the DOM:
            const dayContainer = document.createElement('div')

            // Create an element to hold the temp data:
            const temp = day.main.temp;
            const tempElem = document.createElement('div')
            tempElem.innerText = Math.round(temp) + '°F'
            dayContainer.appendChild(tempElem)

            // Create an image element to hold the icon:
            const icon = day.weather[0].icon;
            const iconElem = document.createElement('img')
            iconElem.src = 'http://openweathermap.org/img/wn/' + icon + '.png'
            dayContainer.appendChild(iconElem)

            // Add the result to the DOM:
            document.body.appendChild(dayContainer)
        })
    })




function getWeatherData() {
    let headers = new Headers();

    return fetch(queryString, {
        method: 'GET',
        headers: headers
    }).then(data => {
        return data.json();
    });
}

getWeatherData().then(weatherData => {
    let city = weatherData.city.name;
    let dailyForecast = weatherData.list;

    renderData(city, dailyForecast);
});

renderData = (location, forecast) => {
    const currentWeather = forecast[0].weather[0];
    const widgetHeader =
        `<h1>${location}</h1><small>${currentWeather.description}</small>`;

    CURRENT_TEMP.innerHTML =
        `<i class="wi ${applyIcon(currentWeather.icon)}"></i>
  ${Math.round(forecast[0].temp.day)} <i class="wi wi-degrees"></i>`;

    CURRENT_LOCATION.innerHTML = widgetHeader;

    // render each daily forecast
    forecast.forEach(day => {
        let date = new Date(day.dt * 1000);
        let days = ['Sun', 'Mon', 'Tues', 'Wed', 'Thurs', 'Fri', 'Sat'];
        let name = days[date.getDay()];
        let dayBlock = document.createElement("div");
        dayBlock.className = 'forecast__item';
        dayBlock.innerHTML =
            `<div class="forecast-item__heading">${name}</div>
      <div class="forecast-item__info">
      <i class="wi ${applyIcon(day.weather[0].icon)}"></i>
      <span class="degrees">${Math.round(day.temp.day)}
      <i class="wi wi-degrees"></i></span></div>`;
        FORECAST.appendChild(dayBlock);
    });
}

fetchForecast = function () {
    var endpoint =
        "https://api.openweathermap.org/data/2.5/onecall?lat=38.7267&lon=-9.1403&exclude=current,hourly,minutely,alerts&units=metric&appid={API key}";
    var forecastEl = document.getElementsByClassName("forecast");

    fetch(endpoint)
        .then(function (response) {
            if (200 !== response.status) {
                console.log(
                    "Looks like there was a problem. Status Code: " + response.status
                );
                return;
            }

            forecastEl[0].classList.add('loaded');

            response.json().then(function (data) {
                var fday = "";
                data.daily.forEach((value, index) => {
                    if (index > 0) {
                        var dayname = new Date(value.dt * 1000).toLocaleDateString("en", {
                            weekday: "long",
                        });
                        var icon = value.weather[0].icon;
                        var temp = value.temp.day.toFixed(0);
                        fday = `<div class="forecast-day">
						<p>${dayname}</p>
						<p><span class="ico-${icon}" title="${icon}"></span></p>
						<div class="forecast-day--temp">${temp}<sup>°C</sup></div>
					</div>`;
                        forecastEl[0].insertAdjacentHTML('afterbegin', fday);
                    }
                });
            });
        })
        .catch(function (err) {
            console.log("Fetch Error :-S", err);
        });
};