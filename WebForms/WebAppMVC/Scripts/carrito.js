
    function obtenerTotal() {
        console.log(10 * 20);
            var precio = document.getElementById("precioId").value;
            var precioNum = parseFloat(precio);
            var cantidad = document.getElementById("cantidadId").value;
            var cantidadNum = parseFloat(cantidad);
            var result = precioNum * cantidadNum;
            document.getElementById("totalId").value = result;


        }
