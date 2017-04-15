using System;

namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// Base class for all POCOs
    /// </summary>
    public abstract class PocoBase
    {
        private Guid _Id = Guid.Empty;

        /// <summary>
        /// Id for the entity
        /// </summary>
        /// <remarks>
        /// If the <see cref="_Id"/> is <see cref="Guid.Empty"/> 
        /// a new <see cref="Guid"/> is generated.
        /// </remarks>
        public Guid Id
        {
            get
            {
                if (_Id == Guid.Empty)
                    _Id = Guid.NewGuid();

                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        /// <summary>
        /// Gets a hascode for a <see cref="PocoBase"/>
        /// </summary>
        /// <returns> a hascode for a <see cref="PocoBase"/></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
