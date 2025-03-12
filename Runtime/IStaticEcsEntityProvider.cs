using System;
using System.Collections.Generic;
using UnityEngine;

namespace FFS.Libraries.StaticEcs.Unity 
{
    public interface IStaticEcsEntityProvider
    {
        bool EntityIsActual();
        
        bool HasComponents();
        void Components(List<IComponent> result);
        void OnSelectComponent(IComponent component);
        void OnChangeComponent(IComponent component, Type componentType);
        void OnDeleteComponent(Type componentType);
        bool ShouldShowComponent(Type componentType, bool runtime);
        
#if !FFS_ECS_DISABLE_TAGS
        void Tags(List<ITag> result);
        void OnSelectTag(Type tagType);
        void OnDeleteTag(Type tagType);
        bool ShouldShowTag(Type tagType, bool runtime);
#endif
            
#if !FFS_ECS_DISABLE_MASKS
        void Masks(List<IMask> result);
        void OnSelectMask(Type maskType);
        void OnDeleteMask(Type maskType);
        bool ShouldShowMask(Type maskType, bool runtime);
#endif
    }
}