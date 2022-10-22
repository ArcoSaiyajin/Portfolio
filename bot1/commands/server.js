module.exports = {
	name: 'server',
	description: 'Server name and member number',
	execute(message, args) {
        message.channel.send(`Server name: ${message.guild.name}\n Total members: ${message.guild.memberCount}`).then(msg => {
            msg.delete({timeout: 10000})}).catch(console.error);
	},
};