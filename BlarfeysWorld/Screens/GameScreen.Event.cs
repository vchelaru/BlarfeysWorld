using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using BlarfeysWorld.Entities;
using BlarfeysWorld.Screens;
namespace BlarfeysWorld.Screens
{
    public partial class GameScreen
    {
        void OnPlayerVsSpikesCollided (Entities.Player player, FlatRedBall.TileCollisions.TileShapeCollection tileShapeCollection) 
        {
            this.RestartScreen();   
        }
        void OnPlayerVsCoinCollided (Entities.Player player, Entities.Coin coin) 
        {
            coin.Destroy();
        }
        void OnPlayerVsKeyCollided (Entities.Player player, Entities.Key key) 
        {
            key.PlayerFollowing = player;
        }
        
    }
}
