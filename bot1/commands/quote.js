function getQuote(id){
    var anime, quote, character;
    const fetch = require('node-fetch');
    fetch('https://animechanapi.xyz/api/quotes/random')
    .then(res => res.json())
    .then(json =>{
        quote = json.data[0].quote;
        anime = json.data[0].anime;
        character = json.data[0].character;
       
    })

    if(id === 1) {
        return quote;
    } else if(id === 2) {
        return character;
    } else if(id === 3) {
        return anime;
    }
}


module.exports = {
	name: 'quote',
	description: 'Quote from anime',
	execute(message, args) {
       const quote = getQuote(1);
       const character = getQuote(2);
       const anime = getQuote(3);
		message.channel.send(`${quote}\nCharacter: ${character}\nAnime: ${anime}`).then(msg => {
            msg.delete({timeout: 10000})}).catch(console.error);
	},
};

