El principio de segregación de interfaces (ISP) es uno de los cinco principios de SOLID, y se enfoca en cómo deberíamos diseñar nuestras interfaces.

El ISP dice que:

"Los clientes no deben ser forzados a depender de interfaces que no utilizan".

Esto significa que en lugar de tener una gran interfaz que puede hacer muchas cosas, deberíamos dividirla en interfaces más pequeñas, cada una con un propósito específico. De esta manera, cuando una clase implemente una interfaz, sólo tendrá que preocuparse por los métodos que realmente necesitará y usará.

Piénsalo de esta manera. Imagina que tienes una gran caja de herramientas con todas las herramientas posibles que pudieras necesitar para cualquier tipo de trabajo en la casa. Sin embargo, la mayoría de las veces, sólo necesitas un destornillador o un martillo. Ahora imagina que cada vez que necesitas una herramienta, tienes que cargar con toda la caja de herramientas, en lugar de simplemente llevar el destornillador o martillo que necesitas. Eso sería bastante ineficiente, ¿verdad?

Bueno, eso es exactamente lo que el ISP trata de evitar. En lugar de obligarte a "cargar" con una gran interfaz llena de métodos que no necesitas (justo como cargar con toda la caja de herramientas), el ISP sugiere dividir esa gran interfaz en interfaces más pequeñas, cada una con un propósito específico (justo como llevar sólo el destornillador o martillo que necesitas.)

Así que, en lugar de tener algo como esto:


public interface IToolBox
{
    void UseHammer();
    void UseScrewdriver();
    void UseWrench();
    // Y muchos más métodos para cada herramienta posible...
}

Deberían tener interfaces más pequeñas y específicas:


public interface IHammer
{
    void UseHammer();
}

public interface IScrewdriver
{
    void UseScrewdriver();
}

public interface IWrench
{
    void UseWrench();
}

// Y así sucesivamente para cada herramienta...

Y entonces, cuando una clase necesita usar una herramienta, sólo necesita implementar la interfaz de esa herramienta específica, en lugar de la gran interfaz de toda la caja de herramientas. Esto hace que tu código sea más fácil de entender y de mantener.