// const mainDiv=document.getElementById("main");
// fetch("https://jsonplaceholder.typicode.com/posts").then(x=>x.json()).then(x=>mainDiv.innerHTML+=`<div class="item">
// <span>1.</span> <a href="#">${x.title}</a>
// </div>`);

// function FillHtml()
// {
// mainDiv.innerHTML+=`<div class="item">
// <span>1.</span> <a href="#">${this.title}</a>
// </div>`;
// }
// FillHtml();

let list = document.querySelector('ol')

fetch('https://jsonplaceholder.typicode.com/posts')
.then(res=>res.json()).then(arr => {
    for (let i = 0; i < arr.length; i++) {
        list.innerHTML += `<li><a href='post.html?${arr[i].id}'>${arr[i].title}</a></li>`;
    }
})