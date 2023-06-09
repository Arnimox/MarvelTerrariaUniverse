﻿using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.UI.Elements;

namespace MarvelTerrariaUniverse.Common.UIElements;
public class UIHoverImageButton : UIImageButton
{
    public string hoverText;
    public UIHoverImageButton(Asset<Texture2D> texture, string hoverText) : base(texture)
    {
        this.hoverText = hoverText;
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
        base.DrawSelf(spriteBatch);

        if (IsMouseHovering) Main.hoverItemName = hoverText;
    }
}
