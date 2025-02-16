using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

public class MultiplayerWarningPlayer : ModPlayer
{
    private const int WarningTimerLength = 180; // Time before message appears (3 seconds)
    private int warningTimer = 0;

    public override void OnEnterWorld()
    {
        if (Main.netMode == NetmodeID.MultiplayerClient) // Check if in multiplayer
            warningTimer = WarningTimerLength;
    }

    public override void PreUpdate()
    {
        if (warningTimer > 0)
        {
            warningTimer--;

            if (warningTimer == 0)
                Main.NewText("[c/ff0000:L][c/ff0001:o][c/ff0002:n][c/ff0003:g][c/ff0004:R][c/ff0005:a][c/ff0007:n][c/ff0008:g][c/ff0009:e][c/ff000a:C][c/ff000b:l][c/ff000c:e][c/ff000e:n][c/ff000f:t][c/ff0010:a][c/ff0011:m][c/ff0012:i][c/ff0013:n][c/ff0015:a][c/ff0016:t][c/ff0017:o][c/ff0018:r][c/ff0019::] [c/ff001c:U][c/ff001d:s][c/ff001e:i][c/ff001f:n][c/ff0020:g] [c/ff0023:t][c/ff0024:h][c/ff0025:e] [c/ff0027:E][c/ff0029:n][c/ff002a:h][c/ff002b:a][c/ff002c:n][c/ff002d:c][c/ff002e:e][c/ff0030:d] [c/ff0032:C][c/ff0033:l][c/ff0034:e][c/ff0036:n][c/ff0037:t][c/ff0038:a][c/ff0039:m][c/ff003a:i][c/ff003b:n][c/ff003d:a][c/ff003e:t][c/ff003f:o][c/ff0040:r] [c/ff0042:i][c/ff0044:n] [c/ff0046:m][c/ff0047:u][c/ff0048:l][c/ff0049:t][c/ff004b:i][c/ff004c:p][c/ff004d:l][c/ff004e:a][c/ff004f:y][c/ff0051:e][c/ff0052:r] [c/ff0054:i][c/ff0055:s] [c/ff0058:N][c/ff0059:O][c/ff005a:T] [c/ff005c:s][c/ff005d:u][c/ff005f:p][c/ff0060:p][c/ff0061:o][c/ff0062:r][c/ff0063:t][c/ff0064:e][c/ff0066:d] [c/ff0068:a][c/ff0069:n][c/ff006a:d] [c/24c6dc:W][c/339cc6:I][c/4273b1:L][c/514a9d:L] [c/ff006e:b][c/ff006f:r][c/ff0070:e][c/ff0071:a][c/ff0073:k] [c/ff0075:t][c/ff0076:h][c/ff0077:e] [c/ff007a:w][c/ff007b:o][c/ff007c:r][c/ff007d:l][c/ff007e:d][c/ff0080:!]", Color.Red);
        }
    }
}