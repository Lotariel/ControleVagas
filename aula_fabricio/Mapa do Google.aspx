<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mapa do Google.aspx.cs" Inherits="aula_fabricio.Mapa_do_Google" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script
      src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAuELP9c_yNxH7g4Y9aIrtG0lA8k6gnIik&callback=initMap&libraries=&v=weekly"
      async="async"
    ></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #map{
            height :400px;
            width :50%;
        }
    </style>
</head>
<body>
    <h1>Meu Mapa do Google</h1>
     <div id="map"></div>
    <form id="form1" runat="server">
        <div>
            <script>
                function initMap() {
                    var map = new google.maps.Map(document.getElementById('map'), { center: { lat: -22.8216, lng: -47.2664 }, zoom: 8, });
                    
                }           
            </script>

        </div>
    </form>
</body>
</html>
