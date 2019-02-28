<<<<<<< HEAD

function converteer() {
=======
function converteer(bedrag , conversie) {
>>>>>>> ba7878521b6d266930e5a3bbdfb6d4f8c38bacd2
    bedrag = (document.getElementById("bedrag").value);
    e = document.getElementById("lijst");
    optie = (e.options[e.selectedIndex].value) * 1;
    krijg = 0;
    switch(optie){
        case 1:
            conversie = 0.74 ;
            krijg = bedrag * conversie;
            document.getElementById("output").innerHTML = krijg + " euro voor " + bedrag+ " dollar";
            break;
        case 2:
            conversie = 1.36;
            krijg = bedrag * conversie;
            document.getElementById("output").innerHTML = krijg + " dollar voor " + bedrag+ "euro";
            break;
        case 3:
            conversie =48.4;
            krijg = bedrag * conversie;
            document.getElementById("output").innerHTML = krijg + " euro voor " + bedrag+ " rubble";
            break;
        case 4:
            conversie = 0.02;
            krijg = bedrag * conversie;
            document.getElementById("output").innerHTML = krijg + " rubble voor " + bedrag+ " euro";
            break;
    }
}