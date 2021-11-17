document.addEventListener("DOMContentLoaded", function Start(){
    document.getElementById("accountLeftButton").addEventListener("click",function (){
        ClearSpaces();
        document.getElementById("accountSpace").removeAttribute("hidden");
    });
    document.getElementById("dialogsLeftButton").addEventListener("click",function (){
        ClearSpaces();
        document.getElementById("dialogsSpace").removeAttribute("hidden");
    });
    document.getElementById("newsLeftButton").addEventListener("click",function (){
        ClearSpaces();
        document.getElementById("newsSpace").removeAttribute("hidden");
    });
    document.getElementById("todosLeftButton").addEventListener("click",function (){
        ClearSpaces();
        document.getElementById("todoSpace").removeAttribute("hidden");
    });
});

function ClearSpaces() {
    document.getElementById("accountSpace").hidden = true;
    document.getElementById("dialogsSpace").hidden = true;
    document.getElementById("newsSpace").hidden = true;
    document.getElementById("todoSpace").hidden = true;
}
