package minecraftplugintest.minecraftplugintest;

import org.bukkit.Bukkit;
import org.bukkit.entity.Player;
import org.bukkit.event.Listener;
import org.bukkit.event.EventHandler;
import org.bukkit.plugin.java.JavaPlugin;
import org.bukkit.event.block.BlockBreakEvent;

public final class MinecraftPluginTest extends JavaPlugin implements Listener {
    @Override
    public void onEnable() {
        // Plugin startup logic
        Bukkit.getLogger().info("MCPluginTest: Enabling");
        getServer().getPluginManager().registerEvents(this, this);
    }

    @Override
    public void onDisable() {
        // Plugin shutdown logic
        Bukkit.getLogger().info("MCPluginTest: Disabling");
    }

    @EventHandler
    public void onBreakBlock(BlockBreakEvent event) {
        Player player = event.getPlayer();
        player.setHealth((int)player.getHealth() - 2);
        System.out.println(player.getHealth());
        if(player.getHealth() <= 1) {
            player.setHealth(0);
        }
    }
}