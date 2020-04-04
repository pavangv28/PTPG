var ar=['#inf1','#inf2','#inf3','#inf4'];


function validate(id)
{
    var element=document.querySelector(ar[id-1]);
    var c=element.value;
    var ch=element.value= element.value.replace(/[^a-zA-Z @]+/,'');

    if(c!=ch)
    alert("Numbers are not allowed in this field");
}