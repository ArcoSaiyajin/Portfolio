module.exports = {
	name: 'ping',
	description: 'Ping!',
	execute(message, args) {
		message.channel.send('Pong.').then(msg => {
            msg.delete({timeout: 10000})}).catch(console.error);
	},
};