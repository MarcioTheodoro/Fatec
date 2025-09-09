document.getElementById("exemplo").innerHTML = "Hahahahah, salve DOM";
document.getElementById("exemplo").style.color = "purple";

const collection = document.getElementsByTagName("h1");
for (let i = 0; i < collection.lenght; i++) {
    collection[i].innerHTML = "Method Finding";
}

function mudarCor() {
    document.getElementById("exemplo").style.color = "violet";
}