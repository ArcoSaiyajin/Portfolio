const Discord = require('discord.js');
const fs = require('fs');
const { prefix, token } = require('./config.json');

const bot = new Discord.Client();
bot.commands = new Discord.Collection();

const commandFiles = fs.readdirSync('./commands').filter(file => file.endsWith('.js'));
for (const file of commandFiles) {

	const command = require(`./commands/${file}`);
	bot.commands.set(command.name, command)
}




bot.once('ready', () => {
    console.log('Bot ready!');
});

bot.on('message', message => {

    const args = message.content.slice(prefix.length).trim().split(/ +/);
    const commandName = args.shift().toLowerCase();

   
    if (!bot.commands.has(commandName)) return;

    const command = bot.commands.get(commandName);

    try 
    {
       command.execute(message, args);
    }
    catch (error) 
    {
        console.error(error);
        message.reply('There was an error trying to execute that command!');
    }
    

     /* else if (message.content.startsWith(`${prefix}matej`)) {
         message.channel.send('IQ: 1000').then(msg => {
           msg.delete({timeout: 10000})}).catch(console.error);
         
     } else if (message.content.startsWith(`${prefix}kejha`)) {
        message.channel.send('IQ: 0').then(msg => {
            msg.delete({timeout: 10000})}).catch(console.error);
      } */
    
    
});


bot.login(token);


bot.on('voiceStateUpdate', (oldState, newState) => {

    const newUserChannel = newState.channel;
    const oldUserChannel = oldState.channel;
    const peepo = bot.channels.cache.get('764131761818828850');
    

    if(oldUserChannel !== null && newUserChannel === undefined)
     {
         
        peepo.send(`${oldState.member.user.username} has left! ${oldUserChannel.name}`).then(msg => {
            msg.delete({timeout: 600000})}).catch(console.error); 
            
        
     }  
     
     else if(newUserChannel !== null && oldUserChannel.id.toString() !== newUserChannel.id.toString()) 
     
     {

        peepo.send(`${newState.member.user.username} has joined! ${newUserChannel.name}`).then(msg => {
            msg.delete({timeout: 600000})}).catch(console.error);
            
   
     }



    
  
})
