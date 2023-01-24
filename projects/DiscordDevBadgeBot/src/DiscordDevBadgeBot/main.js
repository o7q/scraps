const { CommandClient } = require("eris")

async function init(token)
{
    const bot = new CommandClient(`Bot ${token}`,{ intents: ["guilds"], maxShards: "auto", restMode: true })

    bot.on("ready", async () =>
    {
        console.log("I am online!");
        await bot.bulkEditCommands(
        [
            {
            name: "go",
            description: "Do this, and I will go!",
            type: 1,
            }
        ])
    })

    bot.on("interactionCreate", async (interaction) =>
    {
        if (interaction?.data?.name === "go")
        {
            await interaction.createMessage(
            {
                content: "I am going!"
            })
            console.log("Shutting down...");
            process.exit(0);
        }
    })
    bot.connect();
}

const token = "YOUR_BOT_TOKEN";
init(token);