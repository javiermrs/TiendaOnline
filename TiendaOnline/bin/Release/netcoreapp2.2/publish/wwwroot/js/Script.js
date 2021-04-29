var map = L.map('map').
    setView([18.568155, -68.660057],
        10);

L.tileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: 'Map data &copy; <a href="http://openstreetmap.org">OpenStreetMap</a> contributors, <a href="http://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery ©️ <a href="http://cloudmade.com">CloudMade</a>',
    maxZoom: 18
}).addTo(map);
L.control.scale().addTo(map);
var nom;
function Consular() {
    var lat = document.getElementById('lat').value;
    var log = document.getElementById('lng').value;
    let ordenes = document.getElementById('ordenes');
    Latitud = parseFloat(lat);
    Longitud = parseFloat(log);

    L.marker([Latitud, Longitud], { draggable: true }).addTo(map).openPopup().on('click', async function (e) {
        let Cedula = document.getElementById('nombre').value;


        //var node1 = document.createTextNode(data.Nombres);
        //var node2 = document.createTextNode(data.Cedula);

        //nombre.appendChild(node1);
        //cedula.appendChild(node2);

    });


}
//const hola = document.getElementById('hola');
function probar() {
    console.log('progabamdp');
}


function AgregarMarcador(lat, long) {
    console.log();
    console.log(parseFloat(long), parseFloat(lat));
    //const marker = L.marker([parseFloat(lat), parseFloat(long)]).addTo(map);
    L.marker([long, lat], { draggable: true }).addTo(map)
    //L.marker([long, lat]).addTo(map)
    //.bindPopup('su maldita madre')
    //.openPopup();
}

const marker = L.marker();
marker.addEventListener("click", function () {
    alert("tu eres un demagogaso");
});

map.on("click", (e) => {
    let LatLng = map.mouseEventToLatLng(e.originalEvent);
    console.log(LatLng.lat, LatLng.lng);
    let lng = document.getElementById("lng");
    let lat = document.getElementById("lat");

    lat.value = LatLng.lat;
    lng.value = LatLng.lng;
});