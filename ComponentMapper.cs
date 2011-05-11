using System;
namespace Artemis
{
	public class ComponentMapper<T> where T : Component {
		private ComponentType type;
		private EntityManager em;
	
		public ComponentMapper(Component type, EntityManager em) {
			this.em = em;
			this.type = ComponentTypeManager.getTypeFor(type);
		}
	
		public Object get(Entity e) {
			return em.getComponent(e, type);
		}
	}
}
