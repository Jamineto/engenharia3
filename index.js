import express from 'express';


const app = express();



app.use(express());
app.use(express.static('static'));

app.get("/",function(req,res){res.sendFile(process.cwd()+"/static/index.html")})

app.listen(8081, function () {
    console.log("Servidor na porta 8081");
});

 
