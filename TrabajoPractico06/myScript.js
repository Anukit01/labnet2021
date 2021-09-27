
function cleanInputs() {
    document.getElementById("name").value = ''; 
    document.getElementById("surname").value = '';
    document.getElementById("company").value = '';
    document.getElementById("age").value = '';
   }
function validation(){   
    if(document.getElementById("name").value == "" || document.getElementById("surname").value == "")
    {
        alert("You forgot to complete your name or surname. Please complete it.");
    } 
   }