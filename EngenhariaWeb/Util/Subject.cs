namespace EngenhariaWeb.Util
{
    public interface ISubject
    {
        public void AdicionarObservador(IObserver obs);
        public void RemoverObservador(IObserver obs);
        public void NotificarObservadores();
    }
}
