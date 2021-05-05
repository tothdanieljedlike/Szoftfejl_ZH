import {loader} from "@googlemaps/js-api-loader"


let map;

function initMap() {
  map = new google.maps.Map(document.getElementById("map"), {
    center: { lat: -34.397, lng: 150.644 },
    zoom: 8,
  });
}

loader = new Loader({
    apiKey: "AIzaSyDcfi4Cffts6KW26moPInvU4LhoicfpTZs",
    version: "weekly",
    ...additionalOptions,
  });
  loader.load().then(() => {
    map = new google.maps.Map(document.getElementById("map"), {
      center: { lat: -34.397, lng: 150.644 },
      zoom: 8,
    });
  });