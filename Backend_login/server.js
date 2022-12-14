const express = require('express');
const keys = require('./config/keys.js')
const app = express();
const bodyParser = require('body-parser');

//parser application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))

//Setting up DB
const mongoose = require('mongoose');
mongoose.connect(keys.mongoURI, { useNewUrlParser: true, useUnifiedTopology: true });

//Setup database models
require('./model/Account');
require('./model/Score')

//setup routes
require('./routes/authenticationRoutes')(app);
require('./routes/ScoreAuth')(app);

//const port= 13098;
app.listen(keys.port, () => {
    console.log("Listening on " + keys.port);
});