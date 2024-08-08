using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classe base de um Maquina de Estado, usando o loop de Entrada, Atualiza��o e Saida.

public class State : MonoBehaviour
{
    //ENUM (identicador "States") para saber qual o estado atual
    public enum States
    {
        Idle, Winning, Stop
    }

    //ENUM (identicador "State") para saber qual o estagio (fase) do estado
    public enum Event
    {
        //Existe 3 eventos dentro de um estado (entrando, atualizando e saindo).
        Enter, Update, Exit
    }

    //identificar do nome da classe para dar acesso a outros scripts
    public States stateName;

    // Identificador "state" para saber qual o evento ( entrando, loop, estado atual) variavel protected para que apenas essa classe / herdada use o metodo.
    protected Event state;

    // Acessar o sprite da cena (simbolos)
    protected Sprite symbols;

    // Alterar o estado da anima��o
    protected Animator animator;

    // Saber qual o proximo estado
    protected States nextState;

    // Criar um construtor para definir todos os parametros ( passando todos as informa��es dos estados ) 
    public State(Sprite _symbols, Animator _animator)
    {
        //associar as variaveis _ 
        symbols = _symbols;
        animator = _animator;
    }

    //classe virtual para ser sobreescrita e cada metodo tenha sua implementa��o 
    public virtual void Enter ()
    {
       state = Event.Update;
    }

    //update ficara se repetido
    public virtual void Update()
    {
        state = Event.Update;
    }

    //estado de saida
    public virtual void Exit()
    {
        state = Event.Exit;
    }

    //fun�ao para retornar qual e o estado e executar os eventos
    public State Process()
    {
        //verificar se o estado atual e igual o estado de entrada , se tiver, chamar a fun��o Enter
        if (state == Event.Enter)
        {
            Enter();
        }
        else if (state == Event.Update)
        {
            Update();
        }
        else
        {
            Exit();

            //return nextState;
        }

        return this;
    }

}
