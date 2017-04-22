using Newtonsoft.Json;

using SandcastleTest.Generic.POCO;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SandcastleTest.Generic.DAL.FileSystemStorage
{
    /// <inheritdoc/>
    /// <summary>
    /// Handling CRUD actions for file system storage.
    /// </summary>
    public abstract class Crud<T> : ICreateReadUpdateDelete<T>
        where T : PocoBase
    {
        /// <summary>
        /// Gets the file name of the current entity. 
        /// The filename is constructed with the poco class name and the extension .json
        /// </summary>
        private string FileName => $"{typeof(T).Name }.json";

        /// <summary>
        /// Get all contents of the file, containing all the contents of the entity.
        /// </summary>
        private string Content => File.ReadAllText(FileName);

        /// <summary>
        /// Saves a raw string representation to file system.
        /// </summary>
        /// <param name="rawContent">a raw string representation</param>
        private void Store(string rawContent) => File.WriteAllText(FileName, rawContent);

        /// <summary>
        /// Stores a <see cref="List{T}"/> to  the file system
        /// </summary>
        /// <param name="allEntities">all entities</param>
        private void Store(List<T> allEntities) => Store(JsonConvert.SerializeObject(allEntities));

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException">is thrown, when <paramref name="entity"/> is null</exception>
        public void Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var allEntities = GetList();
            if (Exists(allEntities, entity))
                return; // no update on creation

            allEntities.Add(entity);

            Store(allEntities);
        }

        /// <inheritdoc/>
        public bool Delete(T entity)
        {
            var allEntities = GetList();
            if (!(Exists(allEntities, entity)))
                return false ;

            var itemToRemove = allEntities.SingleOrDefault(x => x.Id == entity.Id);
            if (itemToRemove == null)
                return false;

            if (allEntities.Remove(itemToRemove))
            {
                Store(allEntities);
                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public T GetEntity(Guid id) => GetList().SingleOrDefault(x => x.Id == id);

        /// <inheritdoc/>
        public List<T> GetList()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(Content);
            }
            catch
            {
                // maybe file does not exists...
                return new List<T>();
            }
        }

        /// <inheritdoc/>
        public bool Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var allEntities = GetList();
            if (Exists(allEntities, entity)) 
            {
                allEntities.Replace(entity);
                Store(allEntities);

                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks, if <paramref name="allEntities" /> contains a <paramref name="entityToCheck"/>
        /// </summary>
        /// <param name="allEntities">all entities</param>
        /// <param name="entityToCheck">an entity to check</param>
        /// <returns>true, if <paramref name="allEntities" /> contains a <paramref name="entityToCheck"/></returns>
        private bool Exists(List<T> allEntities, T entityToCheck) 
        {
            if (allEntities == null)
                return false;

            return allEntities.Contains(entityToCheck, new PocoBaseEqualityComparer());
        }
    }
}
