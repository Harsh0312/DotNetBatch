package com.example.helloworld;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



    }
    public void btnOnclick(View view){

        EditText edtFirstName=findViewById(R.id.edtFirstName);
        EditText edtLastName=findViewById(R.id.edtLastName);
        EditText edtEmail=findViewById(R.id.edtEmail);
        TextView txtFirstName= findViewById(R.id.txtFirstName);
        TextView txtLastName= findViewById(R.id.txtLastName);
        TextView txtEmail= findViewById(R.id.txtEmail);
        txtFirstName.setText("First Name "+edtFirstName.getText().toString());

        txtLastName.setText("Last Name "+edtLastName.getText().toString());

        txtEmail.setText("Email "+edtEmail.getText().toString());
    }
}
