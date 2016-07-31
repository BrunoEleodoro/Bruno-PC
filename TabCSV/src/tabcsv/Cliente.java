/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tabcsv;

/**
 *
 * @author Alunos
 */
public class Cliente {
    int id;
    String nome;
    String telefone;
    
    void set_id(int i)
    {
        this.id = i;
    }
    int get_id()
    {
        return this.id;
    }
    void set_nome(String nome)
    {
        this.nome = nome;
    }
    String get_nome()
    {
        return this.nome;
    }
    void set_telefone(String tel)
    {
        this.telefone = tel;
    }
    String get_telefone()
    {
        return this.telefone;
    }
    Object[] get_cabecalho()
    {
        Object[] cabecalho = {"id","nome","Telefone"};
        return cabecalho;
    }
    String get_clienteCSV()
    {
        return "\""+this.id+"\";"+this.nome+"\";"+this.telefone+"\"";
    }
    String get_cabecalhoCSV()
    {
        return "\"id\";\"Nome\";\"Telefone\"";
    }
}   
