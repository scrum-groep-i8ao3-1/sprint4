
function converteer() {
    bedrag = (document.getElementById("bedrag").value);
    e = document.getElementById("lijst");
    optie = (e.options[e.selectedIndex].value) * 1;
    krijg = 0;
    koers = 0;
    switch(optie){
        case 1:
            koers = 0.74 ;
            krijg = bedrag * koers;
            document.getElementById("output").innerHTML = krijg + " euro voor " + bedrag+ " dollar";
            break;
        case 2:
            koers = 1.36;
            krijg = bedrag * koers;
            document.getElementById("output").innerHTML = krijg + " dollar voor " + bedrag+ "euro";
            break;
        case 3:
            koers =48.4;
            krijg = bedrag * koers;
            document.getElementById("output").innerHTML = krijg + " euro voor " + bedrag+ " rubble";
            break;
        case 4:
            koers = 0.02;
            krijg = bedrag * koers;
            document.getElementById("output").innerHTML = krijg + " rubble voor " + bedrag+ " euro";
            break;
    }
}