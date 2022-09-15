const mongoose = require('mongoose');

const Score = mongoose.model('score');

module.exports = app => {
    app.post('/score', async (req, res) => {

        var response = {};

        const { rUsername, rScore } = req.body;
        if (rUsername == null || rScore == null) {
            response.code = 1;
            response.msg = "Invalid crededential"
            res.send(response);
            return;
        }

        var userAccount = await Score.findOne({ username: rUsername });
        if (userAccount != null) {

            userAccount.lastAuthentication = Date.now();
            await userAccount.save();

            response.code = 0;
            response.msg = "Account found for score";
            response.data = userAccount;
            res.send(response);

            console.log("Retriving account...")
            res.send(userAccount);

            return;

        }

        console.log(" wala")
        response.code = 1;
        response.msg = "Invalid crededential";
        res.send(response);
        return;

    });
}