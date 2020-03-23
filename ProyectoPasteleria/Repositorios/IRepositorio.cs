namespace ProyectoPasteleria.Repositorios
{
    public interface IRepositorio<T>
    {

        void Agregar(T entidad);
        void Eliminar(T entidad);
        void Actualizar(T entidad);
    }
}
