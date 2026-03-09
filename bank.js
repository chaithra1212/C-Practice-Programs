var name="";
var accNum="";
var phoneNumber="";
var balance=0;
function showAccount(){
    document.getElementById("accountSection").style.display="block";
    document.getElementById("profileSection").style.display="none";
}
function showProfile(){
    document.getElementById("accountSection").style.display="none";
    document.getElementById("profileSection").style.display="block";

    document.getElementById("profileInfo").innerHTML=
    "<b>Name:<b> "+name+"<br>"+
    "<b>Bank Account: <b>"+accNum+"<br>"+
    "<b>Phone number: <b>"+phoneNumber+"<br>"
    "<b>Balance: <b>"+balance+"<br>"
} 
 function createAccount(){
    name=document.getElementById("name").value;
    accNum=document.getElementById("bank").value;
        phoneNumber=document.getElementById("phone").value;
        if(name==""|| bank==""||phone==""){
            alert("Kindly fill the details");
        }
        balance=0;
        document.getElementById("balance").innerHTMl=balance;
        document.getElementById("message").innerHTML=
        "Account created Successfully for " +name;
 }
 function deposit(){
    var amount=Number(document.getElementById("amount").value);
    if(amount>0){
        balance=balance+amount;
        document.getElementById("balance").innerHTML=balance;
        document.getElementById("message").innerHTML=
        "Rs."+amount+"deposited successfully";
    }else{
        alert("enter valid number");
    }
 }
 function withdraw(){
    var amount=Number(document.getElementById("amount").value);
    if(amount>0 && amount<=balance){
        balance=balance-amount;
        document.getElementById("balance").innerHTML=balance;
        document.getElementById("message").innerHTML=
        "Rs."+amount+"withdraw successfully";
    }else{
        alert("Insufficient balance");
    }
 }
 function showSummary(){
    document.getElementById("message").innerHTML=
    "Current Balance: Rs."+balance+" ";
 }
 function logout(){
    name="";
    accNum="";
    phoneNumber="";
    balance=0;
    document.getElementById("balance").innerHTML=0;
    document.getElementById("profileInfo").innerHTML="";
    document.getElementById("message".innerHTML)="";
    alert("Logged out Successfully");
 }