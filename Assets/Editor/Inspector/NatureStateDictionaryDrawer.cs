using UI.InfoPanel.data.state;
using UnityEditor;

namespace Editor.Inspector
{
    [CustomPropertyDrawer(typeof(NatureStateDictionary))]
    public class NatureStateDictionaryDrawer : DictionaryDrawer<StageColor, NatureStateInfo> {}
}