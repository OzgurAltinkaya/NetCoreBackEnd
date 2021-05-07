using System;
namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);//O key e karşılık gelen data
        object Get(string key); //Tip dönüşümü gerek. Generic olmayan version. Type Casting- tip dönüşümü gerek!!

        void Add(string key, object value,int duration);//cacheyi tuttuğumuz-key, gelecek data her şey olabileceği için-object ,duration-cache'nin süresi.
        bool IsAdd(string key); //Bizim cache e eklerken.- cache de var mı yapısı
        //Cache'den ya da veri tabanından getirme; cache de varsa, cache den. yoksa veri tabanından getirip cache e ekleriz!
        void Remove(string key); //cache den silme.
        void RemoveByPattern(string pattern); //Regex Pattern- Reguler Expi. örn-isminde bilmem ne olanları uçur gib.


    }
}
