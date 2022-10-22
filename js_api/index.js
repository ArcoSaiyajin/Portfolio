let quotesDiv = document.getElementById('quotes')

fetch('https://api.kanye.rest')
.then(res => res.json())
.then(quote => {
    quotesDiv.innerHTML += `<p> ${quote.quote} </p>` 
})

let catButton = document.getElementById('give-cat')

catButton.addEventListener("click", evt => {
    let catDiv = document.getElementById('cat-pic')

    fetch('https://api.thecatapi.com/v1/images/search')
    .then(res=> res.json())
    .then(cats => {
        cats.forEach(cat => {
            catDiv.innerHTML = `<h3> Here is pic of a cat </h3>
            <img src="${cat.url}" alt="kitty" />`
        });
    
    })
})

// let po = document.getElementById('idk')
// fetch('https://animechanapi.xyz/api/quotes/random')
// .then(res => res.json())
// .then(idk =>{
//     po.innerHTML += `<p>${idk.data[0].quote}</p><br><p>${idk.data[0].anime}</p><br><p>${idk.data[0].character}</p>`
// })