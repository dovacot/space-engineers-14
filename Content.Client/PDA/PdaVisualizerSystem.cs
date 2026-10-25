using Content.Shared.Light;
using Content.Shared.PDA;
using Robust.Client.GameObjects;

namespace Content.Client.PDA;

public sealed partial class PdaVisualizerSystem : VisualizerSystem<PdaVisualsComponent>
{
    protected override void OnAppearanceChange(EntityUid uid, PdaVisualsComponent comp, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        if (args.TryGetData<string>(PdaVisuals.PdaType, out var pdaType))
            SpriteSystem.LayerSetRsiState((uid, args.Sprite), PdaVisualLayers.Base, pdaType);

<<<<<<< HEAD
        if (AppearanceSystem.TryGetData<bool>(uid, UnpoweredFlashlightVisuals.LightOn, out var isFlashlightOn, args.Component)
            && SpriteSystem.LayerMapTryGet((uid, args.Sprite), PdaVisualLayers.Flashlight, out _, false))
        {
=======
        if (args.TryGetData<bool>(UnpoweredFlashlightVisuals.LightOn, out var isFlashlightOn))
>>>>>>> 56117b042605490051cb5708c4be0
            SpriteSystem.LayerSetVisible((uid, args.Sprite), PdaVisualLayers.Flashlight, isFlashlightOn);
        }

<<<<<<< HEAD
        if (AppearanceSystem.TryGetData<bool>(uid, PdaVisuals.IdCardInserted, out var isCardInserted, args.Component))
        {
            if (SpriteSystem.LayerMapTryGet((uid, args.Sprite), PdaVisualLayers.IdLight, out _, false))
                SpriteSystem.LayerSetVisible((uid, args.Sprite), PdaVisualLayers.IdLight, isCardInserted);

            if (SpriteSystem.LayerMapTryGet((uid, args.Sprite), PdaVisualLayers.CardVisible, out _, false))
                SpriteSystem.LayerSetVisible((uid, args.Sprite), PdaVisualLayers.CardVisible, isCardInserted);
        }
=======
        if (args.TryGetData<bool>(PdaVisuals.IdCardInserted, out var isCardInserted))
            SpriteSystem.LayerSetVisible((uid, args.Sprite), PdaVisualLayers.IdLight, isCardInserted);
>>>>>>> 56117b042605490051cb5708c4be0
    }

    public enum PdaVisualLayers : byte
    {
        Base,
        Flashlight,
        IdLight,
        CardVisible
    }
}
