namespace Svelto.ECS.Internal
{
    static class TypeSafeDictionaryUtilities
    {
        internal static EGIDMapper<T> ToEGIDMapper<T>(this ITypeSafeDictionary<T> dic,
            ExclusiveGroupStruct groupStructId) where T:struct, IBaseEntityComponent
        {
            var mapper = new EGIDMapper<T>(groupStructId, dic);

            return mapper;
        }
    }
}