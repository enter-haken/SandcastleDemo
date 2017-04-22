using SandcastleTest.Generic.POCO;
using System;
using System.Collections.Generic;

namespace SandcastleTest.Generic.DAL
{
    /// <summary>
    /// A base interface for al CRUD operations
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="PocoBase" select="summary"/></typeparam>
    public interface ICreateReadUpdateDelete<T> where T : PocoBase
    {
        /// <summary>
        /// Create a new <paramref name="entity"/>
        /// </summary>
        /// <param name="entity"><inheritdoc cref="PocoBase" select="summary"/></param>
        void Create(T entity);

        /// <summary>
        /// Get a list of <typeparamref name="T"/>
        /// </summary>
        /// <returns>a list of <typeparamref name="T"/></returns>
        List<T> GetList();

        /// <summary>
        /// Get an entity by <see cref="PocoBase.Id"/>
        /// </summary>
        /// <param name="id">The see <see cref="PocoBase.Id"/> of the entity.</param>
        /// <returns>an entity of type <typeparamref name="T"/></returns>
        T GetEntity(Guid id);

        /// <summary>
        /// Update an entity of <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity"><inheritdoc cref="PocoBase" select="summary"/></param>
        /// <returns>if the update succeeded, this method returns true, otherwise false.</returns>
        bool Update(T entity);

        /// <summary>
        /// Deletes an entity of  <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity"><inheritdoc cref="PocoBase" select="summary"/></param>
        /// <returns>if the deletion succeeded, this method returns true, otherwise false.</returns>
        bool Delete(T entity);
    }
}
