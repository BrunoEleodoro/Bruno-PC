/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package compromissos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

/**
 *
 * @author Bruno Eleodoro
 */
public class functions {
    
    //criando uma função
    public ResultSet execute(String sql,String type)
    {
        //variavel para obter o resultado da consulta sql
      ResultSet rs = null;
      try
      {
        //nome do driver a ser utilizado para conexao com banco de dados
        String myDriver = "org.gjt.mm.mysql.Driver";
        //endereço do banco de dados
        String myUrl = "jdbc:mysql://localhost/ds";
        //inicializando o driver
        Class.forName(myDriver);
        //abrir conexao com banco de dados
        Connection conn = DriverManager.getConnection(myUrl, "root", "");        
        //comando sql para ser executado
        String query = sql; 
        //objeto para executar o comando sql
        Statement st = conn.createStatement();
        
        //se o tipo for INSERT ou DELETE
        if(type.equals("INSERT") || type.equals("DELETE"))
        {
            //executeUpdate para inserir dados na tabela
            st.executeUpdate(query);
        }
        else
        {
            //para pegar o retorno do comado sql , exemplo SELECT
            rs = st.executeQuery(query);
        }      
      }
      catch(Exception e)
      {
          //Caso ocorra um erro , mostre no terminal
          System.out.println("Erro= "+e);
      }
      //retornando o resultado da consulta
      return rs;
      
    }
    public String organizarData(String data)
    {
        //pegando partes da data
        //exemplo: 2016-09-03
        String partes[] = data.split("-");
        //03
        String dia = partes[2];
        //09
        String mes = partes[1];
        //2016
        String ano = partes[0];
        //03-09-2016
        String data_final = dia + "-" + mes + "-" + ano;
        return data_final;
    }
}
