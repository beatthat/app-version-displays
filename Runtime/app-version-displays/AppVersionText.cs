using BeatThat.Properties;
using BeatThat.TransformPathExt;
using UnityEngine;

namespace BeatThat.AppVersionDisplays
{
    public class AppVersionText : PropertyBinding<IHasValue<string>, HasText>
    {
        protected override void BindProperty()
        {
            var label = this.driven;
            if(label == null) {
#if UNITY_EDITOR || DEBUG_UNSTRIP
                Debug.LogWarning("[" + this.Path() + "] no label to display application verion");
#endif
                return;
            }
            label.value = Application.version;
        }

    }
}