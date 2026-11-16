namespace tecno1
{
    class Producto
    {
        private string nombre;
        private double precio;
        private int cantidad;


        public string Codigo { get; set; }


        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new Exception("El nombre no puede estar vacio.");

                }
                nombre = value;
            }
        }
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El precio debe ser mayor que 0.");
                }
                precio = value;
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("La cantidad no puede ser negativa.");
                }
                cantidad = value;
            }

        }

        public double Valortotal
        {
            get { return Precio * Cantidad; }


        }


        // creo el constructor para recibir los datos y guardad las propiedades 
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;

        }

        // el void mostrar datos para que se muestren los datos del producto

        public void MostrarInfo()
        {
            Console.WriteLine("Codigo:" + Codigo);
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Precio:" + Precio);
            Console.WriteLine("valor Total: " + Valortotal);
        }
    }
}